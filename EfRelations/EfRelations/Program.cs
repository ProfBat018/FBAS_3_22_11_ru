using EfRelations;
using EfRelations.Services;
using Microsoft.EntityFrameworkCore;

using AcademyContext context = new();

#region Part1

//
// var dataService = new DataService(context);
//
// var groupsData1 = dataService.GetAllData<GroupDatum>();
// var groupsData2 = dataService.GetAllData<GroupDatum>(relatives: "Student,Group");
// var groupsData3 = dataService.GetAllData<GroupDatum>(expression: x => x.GroupId > 5);
// var groupsData4 = dataService.GetAllData<GroupDatum>(x => x.GroupId > 5, "Student,Group");
//
//
// foreach (var item in groupsData4)
// {
//     Console.WriteLine($"{item.Id} {item.Group.Name} {item.Student.Id}");
// }


#endregion

#region Part2


var newData = new GroupDatum
{
   GroupId = context.Groups.First(x => x.Name == "Group1").Id,
   StudentId = context.Students
      .First(x => x.Person.Name == "Elnurio").Id
};

context.GroupData.Add(newData);
context.SaveChanges();


#endregion


// var groupsData = context.GroupData.GetAllData();
// var groupsData2 = context.GroupData.GetAllData(relatives: "Student,Group");
// var groupsData3 = context.GroupData.GetAllData(expression: x => x.GroupId > 5);
// var groupsData4 = context.GroupData.GetAllData(x => x.GroupId > 5, " Student, Group ");
//
//
// foreach (var item in groupsData4)
// {
//     Console.WriteLine(item.Id);
// }
//
//
