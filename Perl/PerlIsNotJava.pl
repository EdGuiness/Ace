use warnings;
use strict;

my $dwarves = "bashful doc dopey grumpy happy sleepy sneezy";

print &ReverseWords($dwarves);

sub ReverseWords {
    my $arg = shift;

    if ($arg) {
        return join ' ', reverse split ' ', $dwarves;
    }
}
