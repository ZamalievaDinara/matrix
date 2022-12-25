using Matrices;
using matrix;
using System;

Matr A = new Matr(3, 7);
Matr B = new Matr(7,1);
int c = 5;
InverseMatrix C = new InverseMatrix(A);
SquareMatrix D = new SquareMatrix();
A.show(); 
(B + A).show();
(A.transposition() * c).show();
