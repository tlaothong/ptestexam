<script>
function loadpage()
{
window.location.reload();
}
</script>
<body>
<?php 
$n=$_POST['name'];
$bmi=$n;
	
	
?>
<table width="1000" border="1" align="center" >
  <tbody>
    <tr>
      <td colspan="2"><img src="https://s.isanook.com/mf/0/news/di/lotto/lotto.jpg" alt="à¸à¸¥à¸à¸²à¸£à¸à¹à¸à¸«à¸²à¸£à¸¹à¸à¸ à¸²à¸à¸ªà¸³à¸«à¸£à¸±à¸ à¸ªà¸¥à¸²à¸à¸à¸´à¸à¹à¸à¹à¸à¸£à¸±à¸à¸à¸²à¸¥" width="993" height="310"/></td>
    </tr>
    <tr>
      <td width="493" align="right" valign="middle">ชื่อ:</td>
      <td width="494" align="left"><?php echo $bmi;?></td>
    </tr>
    <tr>
      <td align="right" valign="top">เลขที่ได้</td>
      <td align="left"><input name="name" type="text" id="textfield2" value="<?php
      echo rand(100000, 999999); 

?>"
        ></td>
    </tr>
  </tbody>
</table>
</body>
</html>