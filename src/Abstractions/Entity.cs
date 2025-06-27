using Emp.src.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.src.Abstractions;
public class Entity<T>
{
    private readonly T? _typeofEmployee;
    public Entity(T typeofEmployee)
    {
        _typeofEmployee = typeofEmployee;
    }
}
