using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastApp.Services.Breakfasts
{
    public record struct UpsertedBreakfast(bool IsNewlyCreated);
}