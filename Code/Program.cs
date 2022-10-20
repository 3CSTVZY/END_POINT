Console.Clear();

char[] body = ("rr31dy").ToCharArray(); 
int count = 0;

#region 
foreach (char item in body)
{ 
if (!char.IsDigit(item))
  {
   count++;
  }
}
#endregion

char[] newArr = new char[count];
count = 0;

#region 
foreach (char item in body) 
{ 
 if (!char.IsDigit(item))
   {
     newArr[count]=item;
     count++;    
   }
}
#endregion

Console.Write("The result: ");
Console.WriteLine(newArr);