use strict; use warnings;

my @list = (
        [qw(Pippin  Hobbit  29)],
        [qw(Merry   Hobbit  37)],
        [qw(Frodo   Hobbit  51)],
        [qw(Legolas Elf     650)],
        [qw(Gimli   Dwarf   140)],
        [qw(Gandalf Maiar   2021)],
        [qw(Aragorn Man     88)],
        [qw(Sam     Hobbit  36)],
        [qw(Boromir Man     41)],
);

my @race = sort { $a->[1] cmp $b->[1] } @list;
print "Sorted by race:\n";
&printCompany(@race);

print "Sorted by age then race:\n";
@race = sort {    $a->[2] <=> $b->[2] 
                  || $a->[1] cmp $b->[1] } @list;

&printCompany(@race);

sub printCompany() {
    
    foreach my $i (@_) {
        print "$i->[0]\t$i->[1]\t$i->[2]\n";
    } 

    print "---\n";
}
