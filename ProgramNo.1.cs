using System;
class ProgramNo1{
    static void Main(){
    char CheckDok = 'n';
    int DokBanCount = 0;
    char Dok = 'y';
    Queue<char> Puangmalai = new Queue<char>();
    while(Dok == 'J'|| Dok == 'G'|| Dok == 'O'|| Dok == 'R'|| Dok == 'y'){
        Dok = char.Parse(Console.ReadLine());

        if(Dok == 'J' ){
            if(CheckDok == Dok){
                Console.WriteLine("Invalid");
                CheckDok = 'J';
            }
        else{
            Puangmalai.Push(Dok);
            CheckDok = 'n';
        }
        }
        else if(Dok == 'O'){
            if(CheckDok == Dok){
                Console.WriteLine("Invalid");
                CheckDok = 'O';
            }
            else{
                Puangmalai.Push(Dok);
                CheckDok = 'n';
            }
        }
        else if (Dok == 'G'){
            if(CheckDok == Dok){
                Console.WriteLine("Invalid");
                CheckDok = 'G';
            }
            else if (DokBanCount<=2){
                DokBanCount++;
                Puangmalai.Push(Dok);
                CheckDok = 'n';
            }
            else if (DokBanCount>2){
                Console.WriteLine("Invalid");
            }
        }
        else if (Dok == 'R'){
            if(Puangmalai.GetLength()==0){
                Console.WriteLine("Invalid");
            }
            else if (Puangmalai.GetLength()>0){
                Puangmalai.Push(Dok);
                CheckDok = Puangmalai.Get(Puangmalai.GetLength()-2);
            }
        }
        }
        for(int i =0; i < Puangmalai.GetLength(); i++){
            Console.Write("{0}",Puangmalai.Get(i),Puangmalai);
        }
    }
    }