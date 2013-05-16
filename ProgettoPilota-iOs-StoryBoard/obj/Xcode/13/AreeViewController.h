// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <UIKit/UIKit.h>
#import <MapKit/MapKit.h>
#import <Foundation/Foundation.h>
#import <CoreGraphics/CoreGraphics.h>


@interface AreeViewController : UITableViewController {
	UITextField *_txtCodice;
	UITextField *_txtDescrizione;
}

@property (nonatomic, retain) IBOutlet UITextField *txtCodice;

@property (nonatomic, retain) IBOutlet UITextField *txtDescrizione;

- (IBAction)Save:(id)sender;

- (IBAction)Delete:(id)sender;

@end
