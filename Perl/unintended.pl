use strict; use warnings;

my @array = (1 .. 9);
my $sum = 0;

foreach my $num (@array) {
    print "$num^2=";
    $num = $num * $num;
    print "$num\n";
    $sum += $num;
}

print "Sum of squares is $sum\n";

print join "\n", @array;
