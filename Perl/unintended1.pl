# Fixes the problem in unintended.pl
#
use strict; use warnings;

my @array = (1 .. 9);
my $sum = 0;

foreach my $num (@array) {
    my $square = $num * $num;
    print "$num^2=" . $square . "\n";
    $sum += $square;
}

print "Sum of squares is $sum\n";

print join "\n", @array;
