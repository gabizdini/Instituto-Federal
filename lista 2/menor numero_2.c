#include <stdio.h>

int main() {
    int n, m, matriz[n][m], menorValor = matriz[0][0];

    printf("Digite o numero de linhas: ");
    scanf("%d", &n);

    printf("Digite o numero de colunas: ");
    scanf("%d", &m);
    
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            printf("Digite o valor da posicao [%d][%d]: ", i, j);
            scanf("%d", &matriz[i][j]);
        }
    }

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            if (matriz[i][j] < menorValor) {
                menorValor = matriz[i][j];
            }
        }
    }
    
    printf("\nO menor valor na matriz: %d", menorValor);
    return 0;
}
