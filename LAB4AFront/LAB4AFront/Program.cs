// See https://aka.ms/new-console-template for more information
using LAB4AFront;

Console.WriteLine("Hello, World!");

int[] n1 = {
 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
var arr1 = new[] { 3, -1, -3, 6, 9, 2, -7, 0, 8, 14, 13, 24, 12, 6, 5 };
var arr1_1 = new[] { 3, 9, 2, 8, 6, 5 };
var arr1_2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };



//ZADANIE 1
var results = n1.Where(num => num % 2 == 0).ToList();

//ZADANIE 2
var results2 = n1.Where(num => num % 2 != 0).ToList();

//ZADANIE 3
var results3 = arr1.Where(num => num > 0 && num < 12).ToList();

//ZADANIE 4
var results4 = arr1_1.Where(num => num * num > 20).ToList();

//ZADANIE 5
var results5 = arr1_2.Select(num => (num, arr1_2.Where(num2 => num2 == num).Count())).Distinct().ToList();

//ZADANIE 6
var str = "abeddwkkecjjeksoiekcllkenndkwel";
var results6 = str.Select(letter => (letter, str.Where(letter2 => letter2 == letter).Count())).Distinct().ToList();

//ZADANIE 7
string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
months.ToList().ForEach(month => Console.WriteLine(month + Environment.NewLine));

//ZADANIE 8
Console.WriteLine("ZADANIE 8");

int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
var results8_1 = nums.Select(num => (num, nums.Where(num2 => num2 == num).Count())).Distinct().ToList();

var results8_2 = nums.ToList().Select(num => (num,
    num * results8_1.Where(pom => pom.num == num).FirstOrDefault().Item2,
    results8_1.Where(pom => pom.num == num).FirstOrDefault().Item2))
    .Distinct().ToList();

//ZADANIE 9
string[] cities = { "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS" };
Console.Write("Find all records ending with letter: ");
var startingLetter = Console.ReadLine();
var results9_1 = cities.Where(city => city.ToLower().StartsWith(startingLetter.ToLower())).ToList();
results9_1.ForEach(res => Console.WriteLine(res + Environment.NewLine));

Console.Write("Find all records ending with letter: ");
var endingLetter = Console.ReadLine();
var results9_2 = cities.Where(city => city.ToLower().EndsWith(endingLetter.ToLower())).ToList();
results9_2.ForEach(res => Console.WriteLine(res + Environment.NewLine));

//ZADANIE 10
Console.WriteLine("ZADANIE 10");

Console.WriteLine("Enter integers list. Enter the 'e' char to stop.");
var stopEntering = false;
var integers = new List<int>();
while(!stopEntering)
{
    var integerStr = Console.ReadLine();
    if (int.TryParse(integerStr, out int parsed))
    {
        integers.Add(parsed);
    }
    else if (integerStr == "e")
    {
        stopEntering = true;
    }
}
Console.Write("Enter the treshold: ");
var tresholdOk= false;
var treshold = 0;
while (!tresholdOk)
{
    var tresholdStr = Console.ReadLine();
    if (int.TryParse(tresholdStr, out int parsed))
    {
        treshold = parsed;
        tresholdOk = true;
    }
    else
    {
        Console.WriteLine("enter proper integer.");
    }
}
var result10 = integers.FindAll(integer => integer > treshold).ToList();
result10.ForEach(res => Console.WriteLine(res + Environment.NewLine));


//ZADANIE 11
Console.WriteLine("ZADANIE 11");
int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
Console.Write("Enter the number of elements: ");
var number = 0;
var numberOK = false;
while (!numberOK)
{
    var numberStr = Console.ReadLine();
    if (int.TryParse(numberStr, out int parsed))
    {
        number = parsed;
        numberOK = true;
    }
    else
    {
        Console.WriteLine("enter proper integer.");
    }
}

number = number > n2.Length ? n2.Length : number;

var result11 = n2.ToList().TakeLast(number);

result11.ToList().ForEach(res => Console.WriteLine(res + Environment.NewLine));

//ZADANIE 12
Console.WriteLine("ZADANIE 12");
int[] n3 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

Console.Write("How many elements should I display?: ");
number = 0;
numberOK = false;
while (!numberOK)
{
    var numberStr = Console.ReadLine();
    if (int.TryParse(numberStr, out int parsed))
    {
        number = parsed;
        numberOK = true;
    }
    else
    {
        Console.WriteLine("enter proper integer.");
    }
}
number = number > n3.Length ? n3.Length : number;

var n3List = n3.ToList();
n3List.Sort();
var result12 = n3List.TakeLast(number).ToList();
result12.ToList().ForEach(res => Console.WriteLine(res + Environment.NewLine));


//ZADANIE 13
var sentence = "example Sentence thiRd worD WORD end Nde.";
Console.WriteLine("Looking for words starting with a capital letter in the sentence: " + sentence);
var splittedSentence = sentence.Split(' ');
var result13 = splittedSentence.Where(word => char.IsUpper(word[0]));
result13.ToList().ForEach(res => Console.WriteLine(res));


//ZADANIE 14
var result = string.Join(", ", months);

//ZADANIE 15
var studentsGenerator = new Students();
var students = studentsGenerator.GtStuRec();
var orderedStudents = students.OrderBy(stu => stu.GroupPoint).ToList();
Console.Write("How many students should I display?: ");
number = 0;
numberOK = false;
while (!numberOK)
{
    var numberStr = Console.ReadLine();
    if (int.TryParse(numberStr, out int parsed))
    {
        number = parsed;
        numberOK = true;
    }
    else
    {
        Console.WriteLine("enter proper integer.");
    }
}
number = number > students.Count ? students.Count : number;
var isNumberInclusive = false;
while (!isNumberInclusive && number != 0)
{
    if (orderedStudents.Count - number - 1 >= 0
        && orderedStudents.Count - number - 1 < orderedStudents.Count
        && orderedStudents[orderedStudents.Count - number].GroupPoint == orderedStudents[orderedStudents.Count - number - 1].GroupPoint)
    {
        number++;
    }
    else
    {
        isNumberInclusive = true;
    }
}

orderedStudents.TakeLast(number).ToList().ForEach(stu => Console.WriteLine(stu.StudentId + " " + stu.StudentName + " " + stu.GroupPoint));


//ZADANIE 16
string[] tab1 = { "a.erc", "b.txt", "c.ldd","d.pdf", "e.PDF","a.pdf", "b.xml", "z.txt", "zzz.doc" };
var grouped = tab1.ToList().GroupBy(fileName => fileName.ToLower().Substring(fileName.IndexOf('.')));
var result16 = grouped.Select(group => (group.Key, group.Count())).ToList();

//ZADANIE 17
int[] listNumArr = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
var listNum = listNumArr.ToList();
Console.WriteLine("Enter integers to be removed. Enter the 'e' char to stop.");
stopEntering = false;
var integersToRemove = new List<int>();
while (!stopEntering)
{
    var integerStr = Console.ReadLine();
    if (int.TryParse(integerStr, out int parsed))
    {
        integersToRemove.Add(parsed);
    }
    else if (integerStr == "e")
    {
        stopEntering = true;
    }
}

var it = 0;
while (listNum.Count > 0 && it < integersToRemove.Count)
{
    listNum.RemoveAll(elem => elem.Equals(integersToRemove[it]));
    it++;
}


//ZADANIE 18
var charset1 = new[] { 'A', 'B', 'C', 'D' };
var numset1 = new[] { 1, 2, 3, 4 };

var result18 = charset1.SelectMany(x => numset1.Select(y => x.ToString() + y.ToString()));

result18.ToList().ForEach(res => Console.WriteLine(res));


//ZADANIE 19
List<Item_mast> itemlist = new List<Item_mast>
 {
 new Item_mast { Id = 1, Descr = "A" },
 new Item_mast { Id = 2, Descr = "B" },
 new Item_mast { Id = 3, Descr = "C" },
 new Item_mast { Id = 4, Descr = "D" },
 new Item_mast { Id = 5, Descr = "E" }
 };

List<Purchase> purchlist = new List<Purchase>
 {
 new Purchase { No=100, Id = 3, Qty = 55 },
 new Purchase { No =101, Id = 2, Qty = 44 },
 new Purchase { No =102, Id = 3, Qty = 555 },
 new Purchase { No =103, Id = 4, Qty = 33 },
 new Purchase { No =104, Id = 3, Qty = 33 },
 new Purchase { No =105, Id = 4, Qty = 44 },
 new Purchase { No =106, Id = 1, Qty = 343 }
 };

var innerJoin = from purchase in purchlist
             join item in itemlist
             on purchase.Id equals item.Id
             select new { Purchase = purchase, Item = item };


//ZADANIE 20
var leftJoin = from purchase in purchlist
               join item in itemlist
               on purchase.Id equals item.Id into gj
               from subitems in gj
               select new
               {
                   Purchase = purchase,
                   Item = subitems
               };


//ZADANIE 21
var rightJoin = from item in itemlist
                join purchase in purchlist
                on item.Id equals purchase.Id into gj
                from subpurchase in gj.DefaultIfEmpty()
                select new
                {
                    Purchase = subpurchase,
                    Item = item
                };


Console.ReadKey();