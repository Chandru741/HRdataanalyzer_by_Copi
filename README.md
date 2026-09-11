# PeoplePulse HR Data Analyzer

A polished, cross-platform HR analytics dashboard built with ASP.NET Core minimal APIs and a dependency-light static frontend. It runs on Linux with .NET 8+ and has no runtime NuGet dependencies.

## Features
- Import and validate CSV or JSON employee data (invalid rows are reported without losing valid records).
- Filter by search, department, location, employment type, status, and salary (API supports salary query filters too).
- Descriptive metrics: headcount, active rate, average/median salary, average performance, department and location distributions.
- Responsive dashboard with accessible table and visual bar charts.
- Export filtered data as CSV, JSON, or standalone HTML.
- Built-in sample data and reset action; health endpoint at `/api/health`.

## Run
```bash
dotnet run --project src/HrDataAnalyzer
# open the printed http://localhost:xxxx URL
```
Use `dotnet build` to compile and `dotnet test` to run core parser, filtering, and analytics tests.

### Import schema
CSV requires headers `id,name,department,hireDate,salary,performanceScore`; optional headers include `role`, `location`, `employmentType`, and `active`. JSON is an array of objects with the same names. Common snake_case and employee aliases are accepted. Dates use ISO formats and performance is 0–100.

## API
`GET /api/employees`, `GET /api/analytics`, `GET /api/options`, `POST /api/import` (multipart field `file`), `POST /api/reset`, and `GET /api/export/{csv|json|html}`. Filter query parameters are `search`, `department`, `location`, `employmentType`, `active`, `minSalary`, and `maxSalary`.
