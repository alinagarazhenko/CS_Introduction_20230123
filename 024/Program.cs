// 24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int quarter=0;
int x=5;
int y=-2;
    
if (x*y == 0) quarter=0;
    else 
    if (x>0 && y>0) quarter=1;
    else 
        if (x<0 && y>0) quarter=2;
            else 
                if (x<0 && y<0) quarter=3;
else quarter=4;

System.Console.WriteLine($"Точка({x}, {y}) в {quarter} четверти");

