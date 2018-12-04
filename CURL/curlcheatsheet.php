<?php
    $curl = curl_init(); //Iniciar
    $url='https://www.google.com';

    curl_setopt($curl,CURLOPT_URL,$url);
    curl_setopt($curl,CURLOPT_SS_VERIFYPEER,false); //para http
    curl_setopt($curl,CURLOPT_RETURNTRANSFER,true); //guardar en variable

    $result=curl_exec($curl);
    echo $result;

    curl_close($curl)//liberar recursos