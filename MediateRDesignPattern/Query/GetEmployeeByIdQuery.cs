using MediateRDesignPattern.Model;
using MediatR;

namespace MediateRDesignPattern.Query
{
    public record GetEmployeeByIdQuery(int Id):IRequest<Employee>
    {
    }
}
