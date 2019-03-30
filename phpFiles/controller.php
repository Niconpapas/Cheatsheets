<?php

$data='';

if(isset($_POST['name'])){
    $name=$_POST['name'];
    $data=$data.'nombre: '.$name;
}
if(isset($_POST['elecmail'])){
    $emial=$_POST['elecmail'];
    $data=$data."\n email: ".$emial;
}

if($data!=''){
    echo $data;
}
else{
    echo 'empty';
}

?>
