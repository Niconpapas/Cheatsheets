document.getElementById('num_one').addEventListener('input',add);
document.getElementById('num_two').addEventListener('input',add);
document.getElementById('item1').addEventListener('click',clickF);
document.getElementById('item2').addEventListener('click',clickF);


function add(){
    var num1=parseFloat(document.getElementById('num_one').value)||0;
    var num2=parseFloat(document.getElementById('num_two').value)||0;

    //console.log(num1+num2);
    document.getElementById('sum').innerHTML=num1+num2;
};

function clickF(){
    //console.log(this);
    var allp=document.getElementById('para').children;

    for(var i=0;i<allp.length;i++)
    {
        allp[i].className="hide";
    };
    

    var itemp=this['attributes']['data-p'].value;
    var p=document.getElementById(itemp);

    if(p.className==="hide")
    {
        p.className="";
    }else{
        p.className="hide";
    };
    
}