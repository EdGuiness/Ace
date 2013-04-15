use strict; use warnings; 

sub sensitiveSort {
    return wantarray ? sort @_ : join ',', sort @_;
}

my @list = ( 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 10, 20, 30, 40);

# list context
print "The first element of the list is: " . (sensitiveSort (@list))[0];

# scalar context
print "\nThe sorted list: " . sensitiveSort(@list);

