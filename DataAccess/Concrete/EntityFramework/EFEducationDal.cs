using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEducationDal : EFEntityRepositoryBase<Education, EducationContext>, IEducationDal
    {
        public List<EducationDto> GetAllEducationDetails(Expression<Func<EducationDto, bool>> filter = null)
        {
            using (EducationContext context = new EducationContext())
            {
                var result = from education in context.Educations
                             join category in context.EducationCategories
                             on education.EducationCategoryId equals category.Id
                             join subCategory in context.EducationSubCategories
                             on category.Id equals subCategory.EducationCategoryId


                             select new EducationDto
                             {
                                 Id = education.Id,
                                 CategoryName = category.EducationCategoryName,
                                 SubCategoryName = subCategory.EducationSubCategoryName,
                                 EducationName = education.EducationName,
                                 Like = education.Like,
                                 Dislike = education.Dislike,
                                 Participants = education.Participants,
                                 Objective = (from objective in context.EducationObjectives where objective.EducationId == education.Id select objective.Objective).ToList(),
                                 Summary = (from summary in context.EducationSummaries where summary.EducationId == education.Id select summary.Summary).ToList(),
                                 TargetAudience = (from targetAudience in context.EducationTargetAudinces where targetAudience.EducationId == education.Id select targetAudience.TargetAudience).ToList(),
                                 Requirement = (from requirement in context.EducationRequirements where requirement.EducationId == education.Id select requirement.Requirement).ToList(),
                                 Achievement = (from achievement in context.EducationAchievements where achievement.EducationId == education.Id select achievement.Achievement).ToList()
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public EducationDto GetEducationDetail(Expression<Func<EducationDto, bool>> filter)
        {
            using (EducationContext context = new EducationContext())
            {
                var result = from education in context.Educations
                             join category in context.EducationCategories
                             on education.EducationCategoryId equals category.Id
                             join subCategory in context.EducationSubCategories
                             on category.Id equals subCategory.EducationCategoryId


                             select new EducationDto
                             {
                                 Id = education.Id,
                                 CategoryName = category.EducationCategoryName,
                                 SubCategoryName = subCategory.EducationSubCategoryName,
                                 EducationName = education.EducationName,
                                 Like = education.Like,
                                 Dislike = education.Dislike,
                                 Participants = education.Participants,
                                 Objective = (from objective in context.EducationObjectives where objective.EducationId == education.Id select objective.Objective).ToList(),
                                 Summary = (from summary in context.EducationSummaries where summary.EducationId == education.Id select summary.Summary).ToList(),
                                 TargetAudience = (from targetAudience in context.EducationTargetAudinces where targetAudience.EducationId == education.Id select targetAudience.TargetAudience).ToList(),
                                 Requirement = (from requirement in context.EducationRequirements where requirement.EducationId == education.Id select requirement.Requirement).ToList(),
                                 Achievement = (from achievement in context.EducationAchievements where achievement.EducationId == education.Id select achievement.Achievement).ToList()
                             };

                return result.Where(filter).SingleOrDefault();
            }
        }
    }


}

