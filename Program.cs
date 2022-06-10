using strng;
using conditional;
using loop;
using arrayList;
using inheritancen;
using getSet;
using Car;
using TypeCast;
// using InputN;
using Enosis;
using stringbuildern;
using Dictionary;
using list;
using split;
using WhiteSpace;
using ds;
using Tree;
// using test;
using deligate;
using linkedList;
using RecursionN;
using callByValueReference;
using margeList;
namespace mainn
{
    class mainc{
        static void Main(string[] args)
        {
            //strng
            // strngc person = new strngc("mahedi","al arafat");
        
            // System.Console.WriteLine(person.fullName().IndexOf("a"));

            // System.Console.WriteLine(person.fullName()[1]);
            
            // strngc.names[0] = "asdas";

            // System.Console.WriteLine(strngc.names[0]);
            // person.age=345;
            // System.Console.WriteLine(person.age);

            //condition
            // conditionC num = new conditionC(34);
            // num.condition();
            
            //switch statement
            // var season = Season.summer;
            // switch (season)
            // {
            //     case Season.summer:
            //         System.Console.WriteLine("This is Summer");
            //         break;
            //     case Season.rainny:
            //         System.Console.WriteLine("This is Rainny Season");
            //         break;
            //     case Season.winter:
            //         System.Console.WriteLine("This is winter");
            //         break;
            //     case Season.spring:
            //         System.Console.WriteLine("This is spring");
            //         break;
                
            //     default:
            //         System.Console.WriteLine("This mught be sum other seson");
            //         break;
            // }

            // looping
            // looping num = new looping();
            // num.loopm();
            
            // //method
            // var currentage = age(2020,1990);
            // System.Console.WriteLine(currentage);
            // int age(int currentYear, int dob)
            // {
            //     return currentYear - dob;
            // }

            // //array List
            // arrayLi li = new arrayLi();
            // li.arrayLiM();
        
            //inheritance
            // Dog dog = new Dog("Audi", 6, "Green", "Bull Dog", "Ghew Ghew");
            // dog.printDetails();
            // dog.Bred();
            // dog.Sound();

            //GETTER SETTER
            // Income amountLeft = new Income();
            // amountLeft.Debit(40000);

            // // amountLeft.income += 50000;

            // System.Console.WriteLine(amountLeft.income);
            // System.Console.WriteLine(amountLeft._income);

            //polymorphism
            // var cars_ = new List<car_>
            // {
            //     new BMW(200, "Black", "A3"),
            //     new Audi(150, "Blue", "Z3")
            // };
            // foreach (var car in cars_)
            // {
            //     System.Console.WriteLine(car);
            //     car.Repair();
            // }

            // //sealed
            // A3 a3 = new A3(200,"Black", "a3001");
            // a3.ShowDetails();

            //typecast
            // TC tc = new TC();
            // tc.typeCastM();

            //input

            // input inp = new input();
            // inp.Input();

            // wrap

            // Wrapc wrp = new Wrapc();
            // wrp.wrapm();
            // wWrapC ww = new wWrapC();
            // ww.wordwrapM();

            // //stringBuilder

            // Stringbuilderc _sb = new Stringbuilderc();
            // _sb.stringbuilderm();

            //repeat
            // Repeat1 rp = new Repeat1();
            // rp.RepeatM();

            // //dictionary
            // Dict dic = new Dict();
            // dic.dictM();

            //list
            // listC ls = new listC();
            // ls.listM();

            //split
            // splitC sp = new splitC();
            // sp.splitM();

            //IpValidation
            // IpValidationC ip = new IpValidationC();
            // ip.IpValidationM(); 

            // reverse
            // ReverseC rs = new ReverseC();
            // rs.ReverseM(); 

            //circularShift  

            // circularShiftC cs = new circularShiftC();
            // cs.circularShiftM(); 

            //whiteSpace
            // whiteSpaceC ws = new whiteSpaceC();
            // ws.whiteSpaceM(); 

            //non repeat
            // nonrepeatC nr = new nonrepeatC();
            // nr.nonrepeatM();  

            //single Loop
            // sLoopC sl = new sLoopC();
            // sl.sLoopM();   

            //avg without max and min
            // avC av = new avC();
            // av.avM(); 
            
            //decode encode
            // D_EncodeC de = new D_EncodeC();
            // de.D_EncodeM();

            // dEncode dE = new dEncode();
            // dE.dEncodeM();

            //ds
            //arrays
            // arrayMultiJagged am = new arrayMultiJagged();
            // am.ArrayTest();

            //strings
            // stringC sc = new stringC();
            // sc.stringM();

            //infix to postfix
            // string str = "K + L - M*N+(O^P)*W/U/V*T+Q^J^A";
            // infixTopostfix ip = new infixTopostfix(str);
            
            // ip.infixTopostfixM();

            // test
            // testC tt = new testC(1);
            // tt.testM();
            
            //infix to postfix_!
            // string str = "K + L - M*N+(O^P)*W/U/V*T+Q^J^A";
            // string str = "4+5";
            // infixTopostfix_1C ip = new infixTopostfix_1C(str);
            // ip.infixTopostfix_1M();

            //evaluatePostfix
            // string str = "795-2*+";
            // // string str = "95-";
            // evaluatePostfixC ep = new evaluatePostfixC(str);
            // ep.evaluatePostfixM();

            //deligate
            
            // delegateC dl = new delegateC();
            // dl.call();

            //delegatecmc
            // deligateCMC dcmc = new deligateCMC();
            // dcmc.start();

            //linkedlist
            // linkedlist ll = new linkedlist();
            // ll.llist();

            //Binary tree
            // Node n = new Node(20);
            // n.tree();


            //recursion
            // indirectRecursionC indR = new indirectRecursionC();
            // indR.Odd(1);

            // Drecursion dr = new Drecursion();
            // dr.mrec();

            //callByValueReference
            // callByValueReferenceC crv = new callByValueReferenceC();
            // crv.call();

            TwoSortedLists ts = new TwoSortedLists();
            ts.margeList();

        }
    }
}