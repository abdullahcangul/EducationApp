



var testDelete = (id, name) => {
   
    Swal.fire({
        title: 'Are you sure to delete ' + name +'?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax(
                {
                    type: "GET",
                    url: '/Test/Delete/' + id,
                    success: function (data) {
                        Swal.fire(
                            'Deleted!',
                            'Your file has been deleted.',
                            'success'
                        )
                        $('#kt_datatable').KTDatatable('reload');
                    },
                    error: function (data) {
                       
                        Swal.fire({
                            title: 'Error!',
                            text: 'Do you want to continue' ,
                            icon: 'error',
                            confirmButtonText: 'Ok'
                        })
                    },
                    
                }
            );
  
        } 
    })
   
}
