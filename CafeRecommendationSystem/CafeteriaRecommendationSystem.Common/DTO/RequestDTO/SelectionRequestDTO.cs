﻿namespace CafeteriaRecommendationSystem.Common.DTO.RequestDTO
{
    public class SelectionRequestDTO
    {
        public int UserId { get; set; }
        public int MenuItemId { get; set; }
        public int MealTypeId { get; set; }
        public DateTime Date { get; set; }
    }
}
