#include "altv.h"

#include <string.h>
#include "version/version.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wempty-body"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif

using alt::Array;

void FreeUIntArray(alt::Array<uint32_t>* array) {
    array->~Array<uint32_t>();
}

/*void FreeStringViewArray(alt::Array<alt::StringView>* array) {
    array->~Array<alt::StringView>();
}*/

/*void FreeStringArray(alt::Array<alt::String>* array) {
    array->~Array<alt::String>();
}*/

/*void FreeMValueArray(alt::Array<alt::MValue>* array) {
    array->~Array<alt::MValue>();
}*/

/*void FreePlayerPointerArray(alt::Array<alt::IPlayer*>* array) {
    array->~Array<alt::IPlayer*>();
}*/

void FreeCharArray(char charArray[]) {
    delete[] charArray;
}

void FreeString(const char* string) {
    delete[] string;
}

const char* GetVersionStatic(int32_t &size) {
    return AllocateString(alt::ICore::Instance().GetVersion(), size);
}

const char* GetBranchStatic(int32_t &size) {
    return AllocateString(alt::ICore::Instance().GetBranch(), size);
}

const char* GetCApiVersion(int32_t &size) {
    return AllocateString(CSHARP_VERSION, size);
}