# FrmSupplier - Quick Reference & Testing Guide

## How to Use FrmSupplier

### Accessing the Form
1. Open KasirIn application
2. Login as Admin (Kasir role cannot access Supplier)
3. Click "Supplier" button in navigation menu
4. FrmSupplier opens in modal dialog

### Adding a New Supplier
1. Click "Tambah Supplier" button
2. FrmSupplierDetail opens with:
   - Auto-generated Kode (e.g., SUP-001)
   - Empty fields for other data
   - Status checkbox checked by default
3. Fill in required fields:
   - **Nama Supplier** (required)
   - Kode can be edited if needed
4. Fill optional fields:
   - Nama Kontak
   - Telepon
   - Email (will validate format)
   - Alamat (multiline)
5. Click "Simpan" to save
6. Form closes and grid refreshes

### Editing a Supplier
**Method 1: Double-click row**
- Double-click any supplier row in grid

**Method 2: Select and click Edit**
- Select supplier row
- Click "Edit" button

**Result:**
- FrmSupplierDetail opens with title "Edit Supplier"
- All fields populated with current data
- Kode can be changed (must remain unique)
- Click "Simpan" to save changes

### Searching Suppliers
1. Type in search box at top
2. Search works on:
   - Supplier name (nama_supplier)
   - Supplier code (kode_supplier)
3. Results update in real-time as you type
4. Search is case-insensitive

### Toggling Active/Inactive Status
1. Select supplier row
2. Click "Nonaktifkan" button
3. Confirmation dialog appears
4. If confirmed:
   - Active supplier → becomes Inactive (gray text)
   - Inactive supplier → becomes Active (black text)
5. Grid refreshes

### Viewing Inactive Suppliers
1. Check "Tampilkan nonaktif" checkbox at top
2. Grid shows all suppliers (active and inactive)
3. Inactive suppliers displayed in gray color
4. Uncheck to show only active suppliers

## Validation Rules

### Nama Supplier
- **Required**: Cannot be empty
- Error: "Nama supplier tidak boleh kosong"

### Kode Supplier
- **Required**: Cannot be empty
- **Unique**: Cannot duplicate existing codes
- Error: "Kode supplier sudah digunakan"
- Auto-generated as SUP-[COUNT+1] padded to 3 digits

### Email
- **Optional**: Can be left blank
- **Format**: Must be valid email if provided
- Error: "Format email tidak valid"
- Example valid: user@example.com

### Other Fields
- Nama Kontak: Optional
- Telepon: Optional
- Alamat: Optional (multiline)

## Database Interactions

### Connection
- Uses `DBConnection.GetConnection()` for all operations
- Parameterized queries for SQL injection prevention
- Proper connection closing in Finally blocks

### Data Operations
- **Load**: SELECT with optional WHERE is_active=1
- **Search**: LIKE queries on nama_supplier and kode_supplier
- **Add**: INSERT with auto-generated kode
- **Edit**: UPDATE with WHERE id_supplier
- **Toggle**: UPDATE with CASE WHEN for is_active

## UI Elements

### FrmSupplier (Main Form)
- **Size**: 950 x 600
- **Top Bar**: Search, Add button, Show inactive checkbox
- **Grid**: 7 columns with full row select
- **Bottom Bar**: Edit, Nonaktifkan buttons, Total count
- **Buttons Enabled**: Only when row selected

### FrmSupplierDetail (Add/Edit Form)
- **Size**: 480 x 500
- **Title**: "Tambah Supplier" or "Edit Supplier"
- **Fields**: 6 text inputs + 1 checkbox
- **Buttons**: Simpan (blue), Batal (gray)

## Color Scheme
- **Active Supplier**: Black text
- **Inactive Supplier**: Gray text
- **Buttons**: Blue (#2563EB) for primary, Gray for secondary
- **Top/Bottom Panels**: Light gray background

## Key Features

✅ **Real-time Search**
- Instant filtering as user types
- Searches both name and code

✅ **Auto-generate Kode**
- Format: SUP-001, SUP-002, etc.
- Based on current supplier count
- Editable before save

✅ **Status Toggle**
- Confirmation dialog before change
- Instant visual feedback (gray color)
- Works both directions (active ↔ inactive)

✅ **Validation**
- Required field checks
- Unique code verification
- Email format validation
- User-friendly error messages

✅ **User Experience**
- Double-click to edit
- Buttons disabled when no selection
- Total supplier count display
- Success/error message boxes
- Modal dialogs for add/edit

## Testing Scenarios

### Scenario 1: Add New Supplier
1. Click "Tambah Supplier"
2. Verify kode auto-generated as SUP-001 (or next number)
3. Enter "PT Maju Jaya" as nama
4. Enter "Budi" as kontak
5. Enter "081234567890" as telepon
6. Enter "budi@majujaya.com" as email
7. Enter "Jl. Sudirman No. 123" as alamat
8. Click "Simpan"
9. Verify success message
10. Verify new supplier appears in grid

### Scenario 2: Search Functionality
1. Add multiple suppliers with different names
2. Type "Maju" in search box
3. Verify only suppliers with "Maju" in name appear
4. Clear search box
5. Type "SUP-001"
6. Verify supplier with that code appears

### Scenario 3: Edit Supplier
1. Double-click supplier row
2. Change nama to "PT Sukses Bersama"
3. Change telepon to "081987654321"
4. Click "Simpan"
5. Verify success message
6. Verify changes appear in grid

### Scenario 4: Toggle Status
1. Select active supplier
2. Click "Nonaktifkan"
3. Confirm dialog
4. Verify supplier becomes gray
5. Select same supplier
6. Click "Nonaktifkan" again
7. Verify supplier becomes black (active)

### Scenario 5: Validation
1. Click "Tambah Supplier"
2. Clear nama field
3. Click "Simpan"
4. Verify error: "Nama supplier tidak boleh kosong"
5. Enter invalid email "notanemail"
6. Click "Simpan"
7. Verify error: "Format email tidak valid"

## Integration with Dashboard

The FrmSupplier is fully integrated with FrmDashboard:
- btnSupplier_Click now opens FrmSupplier (not "Coming Soon")
- Only visible for Admin role (hidden for Kasir)
- Opens as modal dialog
- Grid refreshes when form closes

## Files Modified

1. **FrmSupplier.vb** - Main supplier management form
2. **FrmSupplier.Designer.vb** - UI layout
3. **FrmSupplierDetail.vb** - Add/Edit supplier form
4. **FrmSupplierDetail.Designer.vb** - Detail form UI
5. **FrmDashboard.vb** - Updated btnSupplier_Click
6. **KasirIn.vbproj** - Added form dependencies

## Status: ✅ COMPLETE & TESTED

All features implemented and working:
- ✅ CRUD operations
- ✅ Real-time search
- ✅ Auto-generate kode
- ✅ Validation
- ✅ Status toggle
- ✅ Integration with Dashboard
- ✅ Build successful (0 errors)
