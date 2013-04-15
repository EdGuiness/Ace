
use strict; use warnings;

my @list = qw/three two one six five four nine eight seven/;

my %values = ( 
    'one' => 1,
    'two' => 2,
    'three' => 3,
    'four' => 4,
    'five' => 5,
    'six' => 6,
    'seven' => 7,
    'eight' => 8,
    'nine' => 9
);

my @sorted =
    map { $_->[1] }
    sort { $a->[0] <=> $b->[0] }
    map { [$values{$_}, $_] } @list;

print join ',', @sorted;
