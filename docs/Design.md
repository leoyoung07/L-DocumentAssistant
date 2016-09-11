# Model

1. FileBase
    - GUID
    - Name
    - FullPath
    - Type
    - LastModified
    - CreateTime
1. Document: FileBase
    - Size
1. Folder: FileBase
    - Files
    - DocumentsCount

# Service

1. IndexService
    - Start()
    - Stop()
1. SearchService
    - Search()
1. DocumentService
    - GetFolderInfo()
    - GetDocumentInfo()
1. SettingService
    - GetSettings()
    - Set()
    - Get()

# Global

1. Constant
    - FolderState
1. Util
    - JsonEncode()
    - JsonDecode()


