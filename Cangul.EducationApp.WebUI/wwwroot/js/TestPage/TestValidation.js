// Class definition
var KTFormControls = function () {
	// Private functions

	var _args = {};
	var _initDemo1 = function () {
		FormValidation.formValidation(
			document.getElementById('kt_form_1'),
			{
				fields: {
					Name: {
						validators: {
							notEmpty: {
								message: 'Name is required'
							},
							stringLength: {
								min: 2,
								max: 50,
								message: 'Please enter a name within text length range 2 and 50'
							}
						}
					},


					Description: {
						validators: {
							stringLength: {
								
								max: 500,
								message: 'Please enter max 500 karakter'
							}
						}
					},

				},

				plugins: { //Learn more: https://formvalidation.io/guide/plugins
					trigger: new FormValidation.plugins.Trigger(),
					// Bootstrap Framework Integration
					bootstrap: new FormValidation.plugins.Bootstrap(),
					// Validate fields when clicking the Submit button
					submitButton: new FormValidation.plugins.SubmitButton(),
					// Submit the form when all fields are valid
					defaultSubmit: new FormValidation.plugins.DefaultSubmit(),
				}
			}
		);
	}



	return {
		// public functions
		init: function (Args) {
			_args = Args;
			_initDemo1();
		}
	};
}();

jQuery(document).ready(function () {
	KTFormControls.init();

});


console.log(config);