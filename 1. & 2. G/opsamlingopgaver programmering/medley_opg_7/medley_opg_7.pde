
/*
7 Lokker
. Lav en forlokke der skriver tallene fra og med 0 til og med 99 ud til console
. Lav en forlokke der skriver tallene fra og med 1 til 10 ud i til console
. Lav en forlokke der skriver 7 tabellen ud i consollen
. Lav to forlokker. Den forste forlokke skal kore 5 gange. I kroppen af denne forlokke laves
endnu en forlokke som gentages 10 gange. I den indre forlokke udskrives produktet af de to
variabler som du bruger til at styre dine lokker med til consol. Inden du korer programmet,
hvad forventer du at se ?

*/

void setup() {

    // prints numbers 0-99
    for (int i = 0; i < 100; ++i) {
    println(i);
    }
    println("_______________________");

    // prints numbers 0-10
    for (int j = 0; j < 11; ++j) {
    println(j);
    }
    println("_______________________");

    // prints 7 tables from 0-70
    for (int t7 = 0; t7 < 11; ++t7) {
    println(t7*7);
    }
    println("_______________________");

    // the inner loop prints 10 numbers per increment of the outer loop
    for (int x = 0; x < 5; ++x) {
        for (int y = 0; y < 10; ++y) {
            println(x*y);
        }
    }

    // closes the program when done
    exit();
}





