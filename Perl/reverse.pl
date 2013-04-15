use strict; use warnings;

my $dwarves = "bashful doc dopey grumpy happy sleepy sneezy";

print join ' ', reverse split ' ', $dwarves;

