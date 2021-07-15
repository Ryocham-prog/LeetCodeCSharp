/*
// Definition for Employee.
class Employee {
    public int id;
    public int importance;
    public IList<int> subordinates;
}
*/

class Solution {
    public int GetImportance(IList<Employee> employees, int id) {
        if(employees == null) return 0;
        
        var result = 0;
        foreach(var employee in employees)
        {
            if(employee.id != id) continue;
            
            result += employee.importance;
            
            if(employee.subordinates == null) break;
            
            var subordinates = employee.subordinates;
            foreach(var sub in subordinates)
            {
                result += GetImportance(employees, sub);
            }
            break;
        }       
        return result;
    }
}