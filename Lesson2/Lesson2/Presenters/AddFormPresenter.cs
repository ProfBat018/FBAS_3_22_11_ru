﻿using Lesson2.Models;
using Lesson2.Services;
using Lesson2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson2.Program;

namespace Lesson2.Presenters;
public class AddFormPresenter
{
    public TaskManagerService Service { get; set; } = new();

    public void AddItem(ToDoItem item)
    {
        var fileName = PictureBrowseService.BrowseForPicture();
        if (fileName != null)
        {
            item.ImagePath = fileName;
        }

        AddView.UpdatePicture(item.ImagePath);

        Service.Tasks.Add(item);

        MainView.UpdateListBox(Service.Tasks);

        AddView.Close();
    }
}
