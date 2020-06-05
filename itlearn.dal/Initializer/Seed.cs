using itlearn.dal.Context;
using itlearn.dal.Entities;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.dal.Initializer
{
    public class Seed
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, ApplicationContext context)
        {
            var adminEmail = "admin@gmail.com";
            var password = "_Aa123456";

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await roleManager.FindByNameAsync("moderator") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("moderator"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                var admin = new User { Email = adminEmail, UserName = adminEmail, EmailConfirmed = true };
                var result = await userManager.CreateAsync(admin, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }

            if (context.CategoryCourses.Count() == 0)
            {
                var Blockchain = new CategoryCourse { Name = "Блокчейн" };
                var Business = new CategoryCourse { Name = "Бизнес" };
                var Coding = new CategoryCourse { Name = "Кодирование" };
                var DateScience = new CategoryCourse { Name = "Наука о данных" };
                var Design = new CategoryCourse { Name = "Дизайн" };
                var PersonalDev = new CategoryCourse { Name = "Личное развитие" };

                await context.CategoryCourses.AddRangeAsync(Blockchain, Business, Coding, DateScience, Design, PersonalDev);
                await context.SaveChangesAsync();
            }

            if (context.SubcategoryCourses.Count() == 0)
            {
                var SubBlockchain1 = new SubcategoryCourse { Name = "Криптовалюта", CategoryCourseId = 1 };
                var SubBlockchain2 = new SubcategoryCourse { Name = "Блокчейн разработка", CategoryCourseId = 1 };
                var SubBusiness1 = new SubcategoryCourse { Name = "Финансы", CategoryCourseId = 2 };
                var SubBusiness2 = new SubcategoryCourse { Name = "Бизнес стратегии", CategoryCourseId = 2 };
                var SubBusiness3 = new SubcategoryCourse { Name = "Интернет бизнес", CategoryCourseId = 2 };
                var SubCoding1 = new SubcategoryCourse { Name = "Веб-разработка", CategoryCourseId = 3 };
                var SubCoding2 = new SubcategoryCourse { Name = "Разработка приложений", CategoryCourseId = 3 };
                var SubCoding3 = new SubcategoryCourse { Name = "Разработка игр", CategoryCourseId = 3 };
                var SubCoding4 = new SubcategoryCourse { Name = "Языки программирования", CategoryCourseId = 3 };
                var SubCoding5 = new SubcategoryCourse { Name = "CMS", CategoryCourseId = 3 };
                var SubDateScience1 = new SubcategoryCourse { Name = "Машинное обучение", CategoryCourseId = 4 };
                var SubDateScience2 = new SubcategoryCourse { Name = "Управление БД", CategoryCourseId = 4 };
                var SubDesign1 = new SubcategoryCourse { Name = "Веб-дизайн", CategoryCourseId = 5 };
                var SubDesign2 = new SubcategoryCourse { Name = "Дизайн игры", CategoryCourseId = 5 };
                var SubDesign3 = new SubcategoryCourse { Name = "Дизайн приложения", CategoryCourseId = 5 };
                var SubDesign4 = new SubcategoryCourse { Name = "Графический дизайн", CategoryCourseId = 5 };
                var SubPersonalDev1 = new SubcategoryCourse { Name = "Производительность", CategoryCourseId = 6 };
                var SubPersonalDev2 = new SubcategoryCourse { Name = "Личное выступление", CategoryCourseId = 6 };

                await context.SubcategoryCourses.AddRangeAsync(SubBlockchain1, SubBlockchain2,
                    SubBusiness1, SubBusiness2, SubBusiness3,
                    SubCoding1, SubCoding2, SubCoding3, SubCoding4, SubCoding5,
                    SubDateScience1, SubDateScience2,
                    SubDesign1, SubDesign2, SubDesign3, SubDesign4,
                    SubPersonalDev1, SubPersonalDev2);
                await context.SaveChangesAsync();
            }
        }
    }
}
