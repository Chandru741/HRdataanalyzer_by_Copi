namespace HrDataAnalyzer.Models;
public sealed record Employee(string Id,string Name,string Department,string Role,string Location,string EmploymentType,DateOnly HireDate,decimal Salary,int PerformanceScore,bool Active);
public sealed record ImportResult(IReadOnlyList<Employee> Employees,IReadOnlyList<string> Warnings);
public sealed record FilterOptions(string? Department=null,string? Location=null,string? EmploymentType=null,bool? Active=null,decimal? MinSalary=null,decimal? MaxSalary=null,string? Search=null);
public sealed record AnalyticsSummary(int TotalEmployees,int ActiveEmployees,decimal AverageSalary,decimal MedianSalary,decimal AveragePerformance,DateOnly? EarliestHire,DateOnly? LatestHire, IReadOnlyDictionary<string,int> ByDepartment, IReadOnlyDictionary<string,decimal> SalaryByDepartment);
