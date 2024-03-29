﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolver.Autofac
{
    public class AutofacBuinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EducationManager>().As<IEducationService>().SingleInstance();
            builder.RegisterType<EFEducationDal>().As<IEducationDal>().SingleInstance();

            builder.RegisterType<EducationAchievementManager>().As<IEducationAchievementService>().SingleInstance();
            builder.RegisterType<EFEducationAchievementDal>().As<IEducationAchievementDal>().SingleInstance();

            builder.RegisterType<EducationObjectiveManager>().As<IEducationObjectiveService>().SingleInstance();
            builder.RegisterType<EFEducationObjectiveDal>().As<IEducationObjectiveDal>().SingleInstance();

            builder.RegisterType<EducationSummaryManager>().As<IEducationSummaryService>().SingleInstance();
            builder.RegisterType<EFEducationSummaryDal>().As<IEducationSummaryDal>().SingleInstance();

            builder.RegisterType<EducationRequirementManager>().As<IEducationRequirementService>().SingleInstance();
            builder.RegisterType<EFEducationRequirementDal>().As<IEducationRequirementDal>().SingleInstance();

            builder.RegisterType<EducationTargetAudienceManager>().As<IEducationTargetAudienceService>().SingleInstance();
            builder.RegisterType<EFEducationTargetAudienceDal>().As<IEducationTargetAudienceDal>().SingleInstance();

            builder.RegisterType<EducationImageManager>().As<IEducationImageService>().SingleInstance();
            builder.RegisterType<EFEducationImageDal>().As<IEducationImageDal>().SingleInstance();

            builder.RegisterType<EFVideoTitleDal>().As<IVideoTitleDal>().SingleInstance();
            builder.RegisterType<VideoTitleManager>().As<IVideoTitleService>().SingleInstance();

            builder.RegisterType<EFVideoSubTitleDal>().As<IVideoSubTitleDal>().SingleInstance();
            builder.RegisterType<VideoSubTitleManager>().As<IVideoSubTitleService>().SingleInstance();

            builder.RegisterType<EFEducationVideoDal>().As<IEducationVideoDal>().SingleInstance();
            builder.RegisterType<EducationVideoManager>().As<IEducationVideoService>().SingleInstance();


        }
    }
}
