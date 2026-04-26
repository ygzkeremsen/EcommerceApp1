# Test Report

## Failed Tests and Reasons

1. TotalPrice_ShouldBeCorrect  
   Reason: Cart class applies 10% discount incorrectly.

2. Discount_ShouldNotApply_ForSingleProduct  
   Reason: Discount logic is always applied.

3. MultipleProducts_TotalShouldBeCorrect  
   Reason: Total calculation is incorrect.

4. EmptyCart_TotalShouldBeZero  
   Reason: Discount applied even when cart is empty.

5. PlaceOrder_ShouldFail_WhenCartIsNull  
   Reason: Null cart validation is incorrect.

6. Payment_ShouldFail_ForNegativeAmount  
   Reason: Negative payments are accepted.

## Summary
The system contains intentional bugs and tests successfully detected them.