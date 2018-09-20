<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Untitled Document</title>
</head>

<body>
<div align="center">
  <?php
  $weight=$_POST['weight'];
  $height=$_POST ['height'] ;

  $height=$height/100;
 
  $bmi=$weight/($height*$height);
 
 
  if($bmi<=18.50){
       $c="You're underweight. You should consult your doctor!";
  }else if($bmi>18.50 && $bmi<25){
       $c="You're within the normal weight range.";   
  }else if($bmi>25.5){
       $c="อ้วน";
       $s="อันตราย";   
  }
   ?>
   <h2>ค่า(BMI)ที่ได้</h2>
   
   <p align="center">
   <b>Your BMI : </b><?php echo $bmi;?> bmi<br /><br />
   <b>อยู่ในเกณท์ : </b><?php echo $c;?><br /><br />
   
   </p>   
 
</div>
</body>
</html>