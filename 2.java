package com.company;

public class Main {
    public static int[][]rotate(int[][]array,int i, int j, int k){
        int last = array.length - 1;
        for (i = 0; i < 3; i++) {
            for (j = 0; j < 6 - i * 2; j++) {
                k = array[i][j + i];
                array[i][j + i] = array[last - j - i][i];
                array[last - j - i][i] = array[last - i][last - j - i];
                array[last - i][last - j - i] = array[j + i][last - i];
                array[j + i][last - i] = k;
            }
        }
        return array;
    }
    public static void main(String[] args) {
        int i, j, k;
        System.out.println("Массив:");
        int[][] array = new int[7][7];
        for (i = 0; i < array.length; i++) {
            System.out.println(" ");
            for (j = 0; j < array.length; j++) {
                array[i][j] = (int) (Math.random() * 10);
                System.out.print(array[i][j] + " ");
            }
        }
        System.out.println(" ");
        System.out.println("Поворот на 90°:");
        rotate(array,0,0,0);
        for (i = 0; i < array.length; i++)
        {
            System.out.println(" ");
            for (j = 0; j< array.length; j++)
            {
                System.out.print(array[i][j] + " ");
            }
        }
    }
}
