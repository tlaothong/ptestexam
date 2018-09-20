<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Untitled Document</title>
</head>

    <body class="w3-container">
        <table class="w3-table w3-striped w3-bordered w3-card-4">
            <h3 class="w3-center">ตารางสูตรคูณ</h3>
            <?php
            for ($i = 1; $i <= 5; $i++) {
                echo '<tr>';
                for ($j = 1; $j <= 5; $j++) {
                    echo "<td>" . ($i * $j) . "</td>";
                }
                echo '</tr>';
            }
            ?>
        </table>
    </body>
</html>