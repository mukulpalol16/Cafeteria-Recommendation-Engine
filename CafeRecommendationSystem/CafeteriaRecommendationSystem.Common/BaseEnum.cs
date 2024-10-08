﻿namespace CafeteriaRecommendationSystem.Common
{
    public enum RoleEnum
    {
        None = 0,
        Admin = 1,
        Chef = 2,
        Employee = 3
    }

    public enum MenuItemTypeEnum
    {
        Breakfast = 1,
        Lunch = 2,
        Dinner = 3,
        Beverage = 4
    }

    public enum AvailabilityStatusEnum
    {
        Available = 1,
        Unavailable = 2,
        Deleted = 3,
        OutOfStock = 4,
        OnHold = 5,
        Discarded = 6
    }

    public enum NotificationTypeEnum
    {
        NewFoodItemAdded = 1,
        FoodItemRemoved = 2,
        FoodItemPriceUpdated = 3,
        FoodItemAvailabilityUpdated = 4,
        MenuRolledOut = 5,
        MenuFinalised = 6,
        MenuItemDiscarded = 7
    }

    public enum CharacteristicEnum
    {
        Vegetarian = 1,
        NonVegetarian = 2,
        Eggetarian = 3,
        Spicy = 4,
        Sweet = 5,
        NorthIndian = 6,
        SouthIndian = 7,
        FastFood = 8,
        Dairy = 9
    }
}
