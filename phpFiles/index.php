<?php
    if(isset($_POST['name'])){
        $name = htmlentities($_POST['name']);
        echo $name;
    }
?>

<!DOCTYPE html>
<html>  
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

<script>    
    $(document).ready(()=> {
        $('#btn_cotroller').on('click',phphandler);
    });

    function phphandler(){
        // $.get("controller.php",(data,status)=>{
        //     $('#data').html(data);
        // }); 
        var name=$('#name').val();
        var email=$('#email').val();

        // $.post("controller.php",{
        //     name: name,
        //     elecmail: email    
        // },(data,status)=>{
        //     if(status=="success")
        //     console.log(status);
        //     console.log(data);
        //     $('#data').html(data);
        // });

        $.ajax({
            type: "POST",
            url: "controller.php",
            data: {name:name,elecmail:email},
            
            success: (data)=>{
                console.log(data);
                $('#data').html(data);
            },
            error: (error)=>{
                console.log(error);
            }
        });
    }
</script>
    <head>
    <title>Php CheatSheet</title>
    </head>

    <body>
        <form action="index.php" method="post">
            <div>
                <label >Name</label>
                <input id="name" type="text" name="name">
            </div>
            <div>
                <label >Email</label>
                <input id="email" type="text" name="email" >
            </div>
            <input id="submit" type="submit" value="Submit">           
        </form>

        <div>
            <a href="#" id="btn_cotroller">Get Data</a>
            <p id="data"></p>
        </div>
    </body>
</html>