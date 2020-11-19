using Cangul.EducationApp.Business.Interface;
using Cangul.EducationApp.DataAccess.Interface;
using Cangul.EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.Business.Concrete
{
    public class TopicManager:GenericManager<Topic>,ITopicService
    {
        private readonly ITopicDal _topicDal;

        public TopicManager(ITopicDal topicDal):base(topicDal)
        {
            _topicDal = topicDal;
        }
    }
}
