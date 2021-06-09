namespace hungry_ninja
{
    class Food
    {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy; 
            public bool IsSweet; 
            public Food(string name, int calories, bool isspicy, bool issweet)
            {
                Name=name;
                Calories=calories;
                IsSpicy=isspicy;
                IsSweet=issweet;
            }
    }
    
}