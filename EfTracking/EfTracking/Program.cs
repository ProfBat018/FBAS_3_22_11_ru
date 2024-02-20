using EfTracking.DbContexts;
using Microsoft.EntityFrameworkCore;

using var context = new Academy2Context();

// Eager loading 
var students = context.Students
    .Include(x => x.Person);



