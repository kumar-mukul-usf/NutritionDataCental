using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionDataCental.Models
{
    public class FoodNutrientDerivation
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string description { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }

        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }



    }

    public class FoodNutrientSource
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string description { get; set; }

        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }


    }

    public class FoodCategory
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public List<FoodNutrientSource> FoodNutrientSource { get; set; }

        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }
    }


    public class FoodComponent
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string gramWeight { get; set; }
        public List<FoodNutrientSource> FoodNutrientSource { get; set; }

        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }

    public class FoodPortion
    {
        public int Id { get; set; }
        public string amount { get; set; }
        public string gramWeight { get; set; }

        public int dataPoints { get; set; }
        public List<FoodNutrientSource> FoodNutrientSource { get; set; }

        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }
        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }

    public class FoodCriteria
    {
        public int fdcIds { get; set; }
        public string description { get; set; }
        public string format { get; set; }

        public string nutrients { get; set; }
        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }






    public class InputFoodFoundation
    {
        public int id { get; set; }
        public string foodDescription { get; set; }
        public string inputFood { get; set; }
        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }

    public class AbridgedFoodItem
    {
        public string dataType { get; set; }
        public string foodDescription { get; set; }
        public int fdcID { get; set; }
        public string foodNutrients { get; set; }
        public string publicationDate { get; set; }
        public string brandOwner { get; set; }
        public string gtinUpc { get; set; }
        public int ndbNumber { get; set; }
        public int foodCode { get; set; }
        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }


    }

    public class BrandedFooditem
    {
        public string availableDate { get; set; }
        public string brandOwner { get; set; }
        public int fdcID { get; set; }
        public string dataSource { get; set; }
        public string dataType { get; set; }
        public string description { get; set; }
        public string foodClass { get; set; }
        public string gtinUpc { get; set; }
        public string householdServingFullText { get; set; }
        public string ingredients { get; set; }
        public string modifiedDate { get; set; }
        public int servingSize { get; set; }
        public string servingSizeUnit { get; set; }
        public string brandedFoodCategory { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }

    public class FoundationFooditem
    {
        public string foodClass { get; set; }
        public string footNote { get; set; }
        public int fdcID { get; set; }
        public bool isHistoricalReference { get; set; }
        public string dataType { get; set; }
        public string description { get; set; }
        public string publicationDate { get; set; }
        public string scientificName { get; set; }

        public int ndbNumber { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }

    public class AbridgedFoodNutrient
    {
        public string name { get; set; }
        public float amount { get; set; }
        public int number { get; set; }
        public string derivationCode { get; set; }
        public string unitName { get; set; }
        public string derivationDescription { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }


        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }

    public class FoodNutrient
    {

        public int dataPoints { get; set; }
        public float amount { get; set; }
        public int id { get; set; }
        public float min { get; set; }
        public float max { get; set; }
        public float median { get; set; }

        public string type { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }

    public class Nutrient
    {
        public int id { get; set; }
        public string number { get; set; }
        public string name { get; set; }
        public int rank { get; set; }
        public string unitname { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }


        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }


    }


    public class FoodListCriteria
    {
        public string description { get; set; }
        public string dataType { get; set; }
        public int pageSize { get; set; }
        public string pageNumber { get; set; }
        public string sortBy { get; set; }
        public string sortOrder { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<FoodSearchCriteria> FoodSearchCriteria { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }



    }

    public class FoodSearchCriteria
    {
        public string description { get; set; }
        public string query { get; set; }
        public int dataType { get; set; }
        public int pageSize { get; set; }

        public int pageNumber { get; set; }
        public string sortBy { get; set; }


        public string brandOwner { get; set; }
        public string sortOrder { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }


    public class SearchResult
    {
        public string foodSearchCriteria { get; set; }
        public string foods { get; set; }
        public int totalHits { get; set; }
        public int totalPages { get; set; }

        public int currentPage { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }


        public List<FoodSearchCriteria> SearchResultFood { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }
    }

    public class SearchResultFood
    {
        public string dataType { get; set; }
        public string description { get; set; }
        public int fdcId { get; set; }
        public string foodCode { get; set; }

        public string foodNutrients { get; set; }


        public string publicationDate { get; set; }

        public string scientificName { get; set; }
        public string brandOwner { get; set; }

        public string gtinUpc { get; set; }
        public string ingredients { get; set; }

        public int ndbNumber { get; set; }


        public string additionalDescriptions { get; set; }

        public string allHighlightFields { get; set; }
        public string score { get; set; }

        public List<FoodComponent> FoodComponent { get; set; }

        public List<FoodNutrientSource> FoodNutrientSource { get; set; }
        public List<FoodNutrient> FoodNutrient { get; set; }

        public List<SearchResult> SearchResult { get; set; }

        public List<AbridgedFoodNutrient> AbridgedFoodNutrient { get; set; }

        public List<AbridgedFoodItem> AbridgedFoodItem { get; set; }

    }
}







