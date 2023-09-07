using System.Collections.Generic;

namespace web.Models
{
    public class Person 
    {

    
    public string Name { get; set; }
    public string Address { get; set; }
    
    
    public List<Person> CreatePersons(){
        List<Person> list = new List<Person>();
        list.Add(new Person(){
            Name= "John Makufuli",
            Address="Palace 1 TZ"
        });
        return list;
    }
    
    

}
}