# GPA Calculator Test Cases

## GPA-001: Add valid A course

**Feature:** GPA Calculator  
**Type:** Positive test  
**Steps:**
1. Open GPA Calculator page.
2. Enter credits: 3.
3. Select grade: A.
4. Click Add.

**Expected Result:**  
Course is added and GPA displays as 4.00.

---

## GPA-002: Add multiple courses

**Steps:**
1. Add 3-credit A course.
2. Add 3-credit B course.

**Expected Result:**  
GPA displays as 3.50.

---

## GPA-003: Reject negative credits

**Steps:**
1. Enter credits: -3.
2. Select grade: A.
3. Click Add.

**Expected Result:**  
App should reject the input and display a validation message.

---

## GPA-004: Reject zero credits

**Steps:**
1. Enter credits: 0.
2. Select grade: A.
3. Click Add.

**Expected Result:**  
App should reject zero-credit course.

---

## GPA-005: Handle empty credits field

**Steps:**
1. Leave credits blank.
2. Select grade: B.
3. Click Add.

**Expected Result:**  
App should display required field validation.