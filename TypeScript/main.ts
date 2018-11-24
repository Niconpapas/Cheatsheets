export{}
let message = 'Welcome back';
console.log(message);

let x = 10;
const y = 20;

//let & const
let sum;//can be initialize without a value
const title = 'Typescript Cheatsheet'; //cant be """"

//asignacion de tipos a las variables
let isBeginner:boolean = true;
let total:number = 0;
let name:string ='Nico';

//string format
let sentence:string=`My name is ${name}
I am a Beginner in Typescript`;

console.log(sentence);

//tipo null & undefined

let n:null=null;
let u:undefined=undefined;

let isNew:boolean=null;
let myName:string=undefined;

//Arrays

let list1:number[]=[1,2,3];
let list2:Array<number>=[1,2,3];

let person1:[string,number]=['Ana',22];

//Enum

enum Color{Red=5,Green,Blue};// 0 1 2 // Red=5 => 5 6 7

let c:Color=Color.Green;

console.log(c);

//Anytype

let randoValue:any=10;

randoValue=true;
randoValue='Alice';

let myVariable:unknown=10;//no permite acceder a metodos

function hasName(obj:any):obj is {name:string}{

    return !!obj && typeof obj=="object" && "name" in obj
}

if(hasName(myVariable)){
    console.log(myVariable.name);
}


//(myVariable as string).toUpperCase();

//multitypes

let multiType:number|boolean; //metodos para ambos tipos en intellesense

multiType=20;
multiType=true;

function add(num1:number, num2?:number)
{
    if(num2)
    {
        return num1+num2;
    }
    else{
        return num1;
    }
    
}

add(5,10);
//add('10',1); tira error, checks type
add(5);


//interfaces
interface Person{
    firstName:string;
    lastName?:string; //optional
}

function fullName(person:Person){
    console.log(`${person.firstName} ${person.lastName}`);
}


let p ={firstName:'Bruce', lastName:'Wayne'};

fullName(p);












