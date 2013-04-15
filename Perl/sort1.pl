use strict; use warnings;

my @list = ( 1, 4, 1, 5, 9, 2,  6, 5, 3, 5, 10, 20, 30, 40);
print join ',', sort @list;

print "\n---\n";
print join ',', sort { $a cmp $b } @list;
print "\n---\n";
print join ',', sort { $b <=> $a } @list;

