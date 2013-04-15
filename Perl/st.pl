

my @list = (111111111,22222222,3333333,444444,55555,6666,777,88,9);

my @sorted =
    map { $_->[1] }
    sort { $a->[0] <=> $b->[0] }
    map { [length $_,$_] } @list;

print join ',', @sorted;
