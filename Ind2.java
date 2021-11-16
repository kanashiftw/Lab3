package com.company;

import java.util.Scanner;

public class Main {
        static int SumFirstHalf(int[] myArray,int sum, int i)
        {
            for (i = 0; i < (myArray.length / 2); i++)
            {
                sum += myArray[i];
            }
            return sum;
        }
        static int SumSecondHalf(int[] myArray, int sum, int i)
        {
            for (i = (myArray.length / 2); i < myArray.length; i++)
            {
                sum += myArray[i];
            }
            return sum;
        }
        public static void main (String[] args) throws Exception
        {
            int i,size;
            Scanner in = new Scanner(System.in);
            while(true) {
                try {
                    System.out.println("Введите размер массива(четное число).");
                    while(!in.hasNextInt()) {
                    System.out.println("Вводятся только числа.");
                    in.next();
                    }
                    size = in.nextInt();
                    if (size % 2 != 0) throw new Exception("Число не четное.");
                } catch (Exception ex) {
                    System.out.println(ex.getMessage());
                    continue;
                }break;
            }
            int[] array = new int[size];
            for (i = 0; i < size; i++)
            {
                System.out.println("Введите значение элемента массива.");
                while(!in.hasNextInt()) {
                    System.out.println("Вводятся только числа.");
                    in.next();
                }
                array[i] = in.nextInt();
            }
            System.out.println("Массив:");
            for (int element: array){
            System.out.print(element + " ");
        }
            System.out.println("");
            System.out.println("Сумма элементов первой половины массива: " + SumFirstHalf(array,0,0));
            System.out.println("Сумма элементов второй половины массива: " + SumSecondHalf(array,0,0));
            System.out.println("Разность суммы левой половины элементов и правой: "+ ( SumFirstHalf(array, 0, 0) - SumSecondHalf(array, 0, 0)));
        }
    }
