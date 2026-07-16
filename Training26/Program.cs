int open1 = 0;
int open2 = 0;

Console.Write ("Enter the String : ");
string brackets = Console.ReadLine ().Trim ();
char[] chrbrackets = brackets.ToCharArray ();

bool isbalanced () {
    foreach (var b in chrbrackets) {
        if (b == '[' || b == ']') {
            if (b == ']') {
                open1 -= 1;
                if (open1 < 0) { return false; }
            } else { open1 += 1; }
        } else if (b == '(' || b == ')') {
            if (b == ')') {
                open2 -= 1;
                if (open2 < 0) { return false; }
            } else { open2 += 1; }
        } else {
            Console.WriteLine ("Invalid");
            return false;
        }
    }
    if (open1 == 0 && open2 == 0) { return true; }
    return false;
}

bool isbal = isbalanced ();
if (isbal) {
    Console.WriteLine ("Its Balanced..");
} else {
    Console.WriteLine ("Its Not Balanced");
}