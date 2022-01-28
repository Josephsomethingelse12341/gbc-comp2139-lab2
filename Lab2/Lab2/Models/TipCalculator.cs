using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class TipCalculator
    {
        [Required(ErrorMessage = "Please enter in a valid Meal Cost")]
        [Range(0.0, 1000.0, ErrorMessage = "Cost of a meal must greater than $0 or less than or equal to $1000.0")]
        public double? MealCost { get; set; }

        public double CalculatTip(double precent)
        {
            if (MealCost.HasValue)
            {
                var tip = MealCost.Value * precent;
                return tip;
            }
            return 0.0;
        }


    }
}
