"use strict";
exports.__esModule = true;
var message = 'Welcome back';
console.log(message);
var x = 10;
var y = 20;
//let & const
var sum; //can be initialize without a value
var title = 'Typescript Cheatsheet'; //cant be """"
//asignacion de tipos a las variables
var isBeginner = true;
var total = 0;
var name = 'Nico';
//string format
var sentence = "My name is " + name + "\nI am a Beginner in Typescript";
console.log(sentence);
//tipo null & undefined
var n = null;
var u = undefined;
var isNew = null;
var myName = undefined;
//Arrays
var list1 = [1, 2, 3];
var list2 = [1, 2, 3];
var person1 = ['Ana', 22];
//Enum
var Color;
(function (Color) {
    Color[Color["Red"] = 5] = "Red";
    Color[Color["Green"] = 6] = "Green";
    Color[Color["Blue"] = 7] = "Blue";
})(Color || (Color = {}));
; // 0 1 2 // Red=5 => 5 6 7
var c = Color.Green;
console.log(c);
//Anytype
var randoValue = 10;
randoValue = true;
randoValue = 'Alice';
var myVariable = 10; //no permite acceder a metodos
function hasName(obj) {
    return !!obj && typeof obj == "object" && "name" in obj;
}
if (hasName(myVariable)) {
    console.log(myVariable.name);
}
//(myVariable as string).toUpperCase();
//multitypes
var multiType; //metodos para ambos tipos en intellesense
multiType = 20;
multiType = true;
function add(num1, num2) {
    if (num2) {
        return num1 + num2;
    }
    else {
        return num1;
    }
}
add(5, 10);
//add('10',1); tira error, checks type
add(5);
function fullName(person) {
    console.log(person.firstName + " " + person.lastName);
}
var p = { firstName: 'Bruce', lastName: 'Wayne' };
fullName(p);
