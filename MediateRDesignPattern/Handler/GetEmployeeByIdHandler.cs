using MediateRDesignPattern.Model;
using MediateRDesignPattern.Query;
using MediatR;

namespace MediateRDesignPattern.Handler
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            // Example data; normally fetch from database
            var employee = new Employee
            {
                Id = request.Id,
                Name = "Rahul"
            };

            return await Task.FromResult(employee);
        }
    }
}
