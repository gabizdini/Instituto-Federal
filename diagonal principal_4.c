#include <stdio.h>
#include "biblioteca.h"

int main() {
	int m[100][100], n, c;
   
    printf("Digite o numero de linhas: ");
    scanf("%d", &n);

    printf("Digite o numero de colunas: ");
    scanf("%d", &c);
   
   geraMatriz(m, 100, 100);
   printMatriz(m, n, c);
   
      printf("\nDiagonal Principal:\n");

    for (int i = 0; i < n && i < c; i++) {
        printf("%d |", m[i][i]);//mostras a linha de cada coluna
    }

    printf("\n");
    return 0;
}