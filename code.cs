/* I have a list of objects (Cars). For each car in the list I need to loop through it and find any properties of type DateTime. If I find a property of DateTime I need to get the value and do a time conversion. For now lets just print out the DateTime property value to the console. I am having issues understanding what I need to put in the first parameter of the prop.GetValue function. Any help would be appreciated!*/
foreach (var car in carList)
{  
    foreach (PropertyInfo prop in car.GetType().GetProperties())
    {
         var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
         if (type == typeof (DateTime))
         { 
             Console.WriteLine(prop.GetValue(car, null).ToString());
         }
    }
}
