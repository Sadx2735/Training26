Console.Write ("Enter the Number of Rows : ");
int rows = Convert.ToInt32 (Console.ReadLine ().Trim ());
Console.Write ("Enter the Number of Cols : ");
int cols = Convert.ToInt32 (Console.ReadLine ().Trim ());
Console.WriteLine ($"Rows {rows} and Cols of {cols}");

int[,] Grid = new int[rows, cols];
for (int i = 0; i < rows; i++) {
    for (int j = 0; j < cols; j++) {
        Console.Write ($"Enter the Value for row {i} col {j} : ");
        int number = Convert.ToInt32 (Console.ReadLine ().Trim ());
        Grid[i, j] = number;
    }
}

int Diagonal1 () {
    int total = 0;
    int rnumber = 0;
    int cnumber = 0;
    while (rnumber < rows && cnumber < cols) {
        total += Grid[rnumber, cnumber];
        rnumber++;
        cnumber++;
    }
    return total;
}

int Diagonal2 () {
    int total = 0;
    int rnumber = 0;
    int cnumber = cols - 1;
    while (rnumber < rows && cnumber >= 0) {
        total += Grid[rnumber, cnumber];
        rnumber++;
        cnumber--;
    }
    return total;
}

int Colsum (int Colnumber) {
    int total = 0;
    for (int i = 0; i < rows; i++) {
        total += Grid[i, Colnumber];
    }
    return total;
}

int Rowsum (int rownumber) {
    int total = 0;
    for (int i = 0; i < cols; i++) {
        total += Grid[rownumber, i];
    }
    return total;
}

bool isMagicMatrix () {
    int summation = Rowsum (0);
    for (int i = 1; i < rows; i++) {
        if (summation != Rowsum (i)) {
            return false;
        }
    }
    for (int i = 0; i < cols; i++) {
        if (summation != Colsum (i)) {
            return false;
        }
    }
    if (Diagonal1 () != summation) { return false; }
    if (Diagonal2 () != summation) { return false; }
    return true;
}

bool result = isMagicMatrix ();
if (result) {
    Console.WriteLine ($"The Given Matrix is a Magic Matrix");
} else {
    Console.WriteLine ($"The Given Matrix is not Magic Matrix");
}