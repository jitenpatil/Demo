using Domain;

namespace Persistance
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Steppers != null && context.Steppers.Any()) return;

            var steppers = new List<Stepper>
            {
                new Stepper
                {
                    Code = "AI",
                    Title = "Application Information",
                    IsActive = true,
                    IsVisited = false,
                    NodeStepNumber = 1,
                    NodeTextHTMLElement = "",
                    NodeStepNumberHTMLElement = "",
                    IsHidden = false,
                    IsSubNode = false,
                    IsChildNode = false,
                    NodeType = "parent",
                    IsComplete = false,
                    ChildList = "",
                    DisplayNodeNumber = 1,
                    DisplayPercentForParentNode = 0,
                    ParentCode = "",
                }
            };

            await context.Steppers.AddRangeAsync(steppers);
            await context.SaveChangesAsync();
        }
    }

}