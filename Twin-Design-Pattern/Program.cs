using Twin_Design_Pattern;

ChildAcademistOperation childAcademistOperation = new();
ChildRectorOperation childRectorOperation = new();

childAcademistOperation.GetFullName();
childAcademistOperation.ChildRectorOperation = new();
childAcademistOperation.GetPermissionType();
childAcademistOperation.ChildRectorOperation.GetPermissionType();

Console.WriteLine("***");

childRectorOperation.GetFullName();
childRectorOperation.AcademistOperation = new();
childRectorOperation.GetPermissionType();
childRectorOperation.AcademistOperation.GetPermissionType();